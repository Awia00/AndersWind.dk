properties([
    buildDiscarder(logRotator(numToKeepStr: '3'))
])
node('docker&&linux') {
    stage('Fetch SCM') {
        checkout scm
    }
    stage('Website Build') {
        docker.build('awia/anderswind.dk')
    }
    stage('Deploy') {
        sh 'docker-compose up -d'
    }
}