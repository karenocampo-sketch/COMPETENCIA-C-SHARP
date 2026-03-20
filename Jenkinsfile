pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh 'dotnet build MiProyecto/MiProyecto.csproj'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test MiProyecto.Tests/MiProyecto.Tests.csproj'
            }
        }
    }
}
