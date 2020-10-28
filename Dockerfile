FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
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

EXPOSE 8000

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CharityApp.Web.Service.dll"]