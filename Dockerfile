FROM hub.lumigame.com/base/dotnet/core/aspnet:9.0-alpine AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

USER app
FROM --platform=$BUILDPLATFORM hub.lumigame.com/base/dotnet/core/sdk:9.0-alpine AS builder
ARG configuration=Release
WORKDIR /src
COPY ["TGWallet.Api/TGWallet.Api.csproj", "TGWallet.Api/"]
RUN dotnet restore "TGWallet.Api/TGWallet.Api.csproj"
COPY . .
WORKDIR "/src/TGWallet.Api"
RUN dotnet build "TGWallet.Api.csproj" -c $configuration -o /app/build

FROM builder AS publish
ARG configuration=Release
RUN dotnet publish "TGWallet.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TGWallet.Api.dll"]
