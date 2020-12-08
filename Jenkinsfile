pipeline {
	agent none

    stages {
        stage('Build') {
		agent { label 'win01' }
            steps {
                echo 'Building..'
				bat "dotnet build"
		    stash name: "exe", includes: "bin/Debug/*"
            }
        }
        stage('Test') {
		agent { label 'win01' }
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
		agent { label 'win02' }
            steps {
                echo 'Deploying....'
		unstash name: "exe"
            }
        }
    }
}
