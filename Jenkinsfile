pipeline {
    agent win01

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				bat "dotnet build"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
