FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 54691
EXPOSE 44388

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY RestfulChess/RestfulChess.csproj RestfulChess/
RUN dotnet restore RestfulChess/RestfulChess.csproj
COPY . .
WORKDIR /src/RestfulChess
RUN dotnet build RestfulChess.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish RestfulChess.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RestfulChess.dll"]
