pipeline {
	agent none

    stages {
        stage('Build') {
		agent { label 'win01' }
            steps {
                echo 'Building..'
		bat "dotnet build"
		dir('c:\\jenkins01\\workspace\\test_01_multi_tloy1966-patch-1\\Jenkins_Test_01\\bin\\debug\\'){
    			stash name: 'exe', includes:'*.exe'
			}
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
		    dir('c:\\jenkins02\\workspace\\test_01_multi_tloy1966-patch-1\\Jenkins_Test_01\\bin\\debug\\'){
    			unstash name: 'exe'
			}
            }
        }
    }
}
