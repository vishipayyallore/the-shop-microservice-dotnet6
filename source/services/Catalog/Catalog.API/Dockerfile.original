#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/services/Catalog/Catalog.API/Catalog.API.csproj", "source/services/Catalog/Catalog.API/"]
COPY ["source/services/Catalog/Catalog.Repository/Catalog.Repository.csproj", "source/services/Catalog/Catalog.Repository/"]
COPY ["source/services/Catalog/Catalog.Core/Catalog.Core.csproj", "source/services/Catalog/Catalog.Core/"]
COPY ["source/services/Catalog/Catalog.Infrastructure/Catalog.Infrastructure.csproj", "source/services/Catalog/Catalog.Infrastructure/"]
COPY ["source/services/Catalog/Catalog.Data/Catalog.Data.csproj", "source/services/Catalog/Catalog.Data/"]
RUN dotnet restore "source/services/Catalog/Catalog.API/Catalog.API.csproj"
COPY . .
WORKDIR "/src/source/services/Catalog/Catalog.API"
RUN dotnet build "Catalog.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Catalog.API.dll"]