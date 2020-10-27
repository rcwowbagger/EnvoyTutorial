FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CoffeeApi/CoffeeApi.csproj", "CoffeeApi/"]
RUN dotnet restore "CoffeeApi/CoffeeApi.csproj"
COPY . .
WORKDIR "/src/CoffeeApi"
RUN dotnet build "CoffeeApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeApi.dll"]