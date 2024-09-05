#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/ThreeTenant.Web.Host/ThreeTenant.Web.Host.csproj", "src/ThreeTenant.Web.Host/"]
COPY ["src/ThreeTenant.Web.Core/ThreeTenant.Web.Core.csproj", "src/ThreeTenant.Web.Core/"]
COPY ["src/ThreeTenant.Application/ThreeTenant.Application.csproj", "src/ThreeTenant.Application/"]
COPY ["src/ThreeTenant.Application.Shared/ThreeTenant.Application.Shared.csproj", "src/ThreeTenant.Application.Shared/"]
COPY ["src/ThreeTenant.Core.Shared/ThreeTenant.Core.Shared.csproj", "src/ThreeTenant.Core.Shared/"]
COPY ["src/ThreeTenant.Core/ThreeTenant.Core.csproj", "src/ThreeTenant.Core/"]
COPY ["src/ThreeTenant.EntityFrameworkCore/ThreeTenant.EntityFrameworkCore.csproj", "src/ThreeTenant.EntityFrameworkCore/"]
COPY ["src/ThreeTenant.GraphQL/ThreeTenant.GraphQL.csproj", "src/ThreeTenant.GraphQL/"]
RUN dotnet restore "src/ThreeTenant.Web.Host/ThreeTenant.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/ThreeTenant.Web.Host"
RUN dotnet build "ThreeTenant.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ThreeTenant.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ThreeTenant.Web.Host.dll"]
