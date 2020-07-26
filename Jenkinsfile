pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				bat "dotnet build"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing......0'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}