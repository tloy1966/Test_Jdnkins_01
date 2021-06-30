pipeline {
    agent any
    options {
  	retry(3)
        disableConcurrentBuilds()
    }
	triggers {
			githubPush()
		}
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
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
