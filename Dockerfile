FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base

ENV ASPNETCORE_URLS http://+:5000

WORKDIR /src
COPY CharityAppAPI.sln ./
COPY CharityApp.Core/*.csproj ./CharityApp.Core/
COPY CharityApp.Data/*.csproj ./CharityApp.Data/
COPY CharityApp.Services/*.csproj ./CharityApp.Services/
COPY CharityApp.Web.Service/*.csproj ./CharityApp.Web.Service/

RUN dotnet restore
COPY . .
WORKDIR /src/CharityApp.Core
RUN dotnet build -c Release -o /app

WORKDIR /src/CharityApp.Data
RUN dotnet build -c Release -o /app

WORKDIR /src/CharityApp.Services
RUN dotnet build -c Release -o /app

WORKDIR /src/CharityApp.Web.Service
RUN dotnet build -c Release -o /app

FROM base AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

#ENTRYPOINT ["dotnet", "CharityApp.Web.Service.dll"]