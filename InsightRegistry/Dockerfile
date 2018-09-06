FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY InsightRegistry/InsightRegistry.csproj InsightRegistry/
RUN dotnet restore InsightRegistry/InsightRegistry.csproj
COPY . .
WORKDIR /src/InsightRegistry
RUN dotnet build InsightRegistry.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish InsightRegistry.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "InsightRegistry.dll"]
