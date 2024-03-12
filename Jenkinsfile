pipeline {
  agent any
  stages {
    stage('Record Jacoco Coverage Report') {
      steps {
        jacoco()
      }
    }

    stage('Check out') {
      steps {
        git(url: 'https://github.com/yhlica/MavenProject4COMP367.git', branch: 'master', poll: true)
      }
    }

  }
}