#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ItemCatalogService.gRPCService/ItemCatalogService.gRPCService.csproj", "ItemCatalogService.gRPCService/"]
COPY ["ItemCatalogService.Data/ItemCatalogService.Data.csproj", "ItemCatalogService.Data/"]
RUN dotnet restore "ItemCatalogService.gRPCService/ItemCatalogService.gRPCService.csproj"
COPY . .
WORKDIR "/src/ItemCatalogService.gRPCService"
RUN dotnet build "ItemCatalogService.gRPCService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ItemCatalogService.gRPCService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ItemCatalogService.gRPCService.dll"]
