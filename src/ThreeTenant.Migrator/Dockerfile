#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ThreeTenant.Migrator/ThreeTenant.Migrator.csproj", "src/ThreeTenant.Migrator/"]
COPY ["src/ThreeTenant.EntityFrameworkCore/ThreeTenant.EntityFrameworkCore.csproj", "src/ThreeTenant.EntityFrameworkCore/"]
COPY ["src/ThreeTenant.Core/ThreeTenant.Core.csproj", "src/ThreeTenant.Core/"]
COPY ["src/ThreeTenant.Core.Shared/ThreeTenant.Core.Shared.csproj", "src/ThreeTenant.Core.Shared/"]
RUN dotnet restore "src/ThreeTenant.Migrator/ThreeTenant.Migrator.csproj"
COPY . .
WORKDIR "/src/src/ThreeTenant.Migrator"
RUN dotnet build "ThreeTenant.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ThreeTenant.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ThreeTenant.Migrator.dll", "-s"]
