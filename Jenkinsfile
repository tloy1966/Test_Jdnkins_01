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
                echo 'Testing.....1...'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying.....'
            }
        }
    }
}
