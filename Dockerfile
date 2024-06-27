FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.19-amd64

WORKDIR /app

COPY chefstock-platform/ .
RUN dotnet restore

RUN dotnet publish -c Release -o out

EXPOSE 80

ENTRYPOINT ["dotnet", "out/chefstock-platform.dll"]
