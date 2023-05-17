FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["instagram-copy-backend/instagram-copy-backend.csproj", "instagram-copy-backend/"]
RUN dotnet restore "instagram-copy-backend/instagram-copy-backend.csproj"
COPY . .
WORKDIR "/src/instagram-copy-backend"
RUN dotnet build "instagram-copy-backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "instagram-copy-backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "instagram-copy-backend.dll"]
