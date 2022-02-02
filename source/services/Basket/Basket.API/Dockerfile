#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/services/Basket/Basket.API/Basket.API.csproj", "source/services/Basket/Basket.API/"]
COPY ["source/services/Basket/Basket.Repository/Basket.Repository.csproj", "source/services/Basket/Basket.Repository/"]
COPY ["source/services/Basket/Basket.Core/Basket.Core.csproj", "source/services/Basket/Basket.Core/"]
RUN dotnet restore "source/services/Basket/Basket.API/Basket.API.csproj"
COPY . .
WORKDIR "/src/source/services/Basket/Basket.API"
RUN dotnet build "Basket.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basket.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Basket.API.dll"]