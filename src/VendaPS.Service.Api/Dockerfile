FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["src/VendaPS.Service.Api/VendaPS.Service.Api.csproj", "src/VendaPS.Service.Api/"]
RUN dotnet restore "src/VendaPS.Service.Api/VendaPS.Service.Api.csproj"
COPY . .
WORKDIR "/src/src/VendaPS.Service.Api"
RUN dotnet build "VendaPS.Service.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VendaPS.Service.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VendaPS.Service.Api.dll"]