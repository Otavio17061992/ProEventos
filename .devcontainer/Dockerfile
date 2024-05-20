FROM mcr.microsoft.com/devcontainers/dotnet:1-6.0

# Install SQL Tools: SQLPackage and sqlcmd
COPY mssql/installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
     && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts

# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# Instale o EF 7
RUN dotnet tool install --global dotnet-ef --version 7.0.0

# Instale o Node.js versão 14
RUN curl -sL https://deb.nodesource.com/setup_14.x | bash - \
    && apt-get install -y nodejs


RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && nvm install 14 && nvm use 14 && npm install -g @angular/cli@12" 2>&1
