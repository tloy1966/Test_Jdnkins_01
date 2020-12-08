pipeline {
	agent none

    stages {
        stage('Build') {
		agent { label 'win01' }
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
