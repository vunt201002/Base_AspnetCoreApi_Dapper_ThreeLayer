#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Base_AspnetCoreApi_Dapper_ThreeLayer/Base_AspnetCoreApi_Dapper_ThreeLayer.csproj", "Base_AspnetCoreApi_Dapper_ThreeLayer/"]
RUN dotnet restore "Base_AspnetCoreApi_Dapper_ThreeLayer/Base_AspnetCoreApi_Dapper_ThreeLayer.csproj"
COPY . .
WORKDIR "/src/Base_AspnetCoreApi_Dapper_ThreeLayer"
RUN dotnet build "Base_AspnetCoreApi_Dapper_ThreeLayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Base_AspnetCoreApi_Dapper_ThreeLayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Base_AspnetCoreApi_Dapper_ThreeLayer.dll"]