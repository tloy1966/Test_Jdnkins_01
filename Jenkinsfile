pipeline {
    agent any
    options {
  	retry(3)
        disableConcurrentBuilds()
    }
    tools {
	msbuild 'MS4.0'
    }
	
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				bat "dotnet build"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing.....12...'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying.....'
            }
        }
    }
}
