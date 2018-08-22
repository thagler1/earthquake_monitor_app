pipeline {
  agent any
  stages {
    stage('Get earthquake1') {
      parallel {
        stage('Get earthquake1') {
          steps {
            dir(path: 'eq1') {
              git(url: 'https://github.com/thagler1/earthquake_monitor_app.git', branch: 'master', credentialsId: '3d03be36dede2fdca48a3ddaa54d349279e8c9a8')
            }

          }
        }
        stage('Get EQ2') {
          steps {
            dir(path: 'eq2') {
              git(url: 'https://github.com/thagler1/earthquake_monitor_app.git', credentialsId: '3d03be36dede2fdca48a3ddaa54d349279e8c9a8', branch: 'master')
            }

          }
        }
      }
    }
  }
}