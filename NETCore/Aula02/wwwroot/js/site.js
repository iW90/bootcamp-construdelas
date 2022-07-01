//Função de soma
function somar() {
    var resultado = document.getElementById('resultado');
    var valorUm = document.getElementById('valorUm');
    var valorDois = document.getElementById('valorDois');

    var item = {
        valorUm: parseInt(valorUm.value),
        valorDois: parseInt(valorDois.value),
        resultado: parseInt(resultado.value)
    };

    fetch('/home/somar', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (result) {
            resultado.value = result.resultado;
            valorUm.value = result.valorUm;
            valorDois.value = result.valorDois;
        })
        .catch(error => console.error('Unable to add item.', error));
}

//Função de subtração
function subtrair() {
    var resultado = document.getElementById('resultado');
    var valorUm = document.getElementById('valorUm');
    var valorDois = document.getElementById('valorDois');

    var item = {
        valorUm: parseInt(valorUm.value),
        valorDois: parseInt(valorDois.value),
        resultado: parseInt(resultado.value)
    };

    fetch('/home/subtrair', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (result) {
            resultado.value = result.resultado;
            valorUm.value = result.valorUm;
            valorDois.value = result.valorDois;
        })
        .catch(error => console.error('Unable to add item.', error));
}


//Função de multiplicação
function multiplicar() {
    var resultado = document.getElementById('resultado');
    var valorUm = document.getElementById('valorUm');
    var valorDois = document.getElementById('valorDois');

    var item = {
        valorUm: parseInt(valorUm.value),
        valorDois: parseInt(valorDois.value),
        resultado: parseInt(resultado.value)
    };

    fetch('/home/multiplicar', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (result) {
            resultado.value = result.resultado;
            valorUm.value = result.valorUm;
            valorDois.value = result.valorDois;
        })
        .catch(error => console.error('Unable to add item.', error));
}


//Função de dividir
function dividir() {
    var resultado = document.getElementById('resultado');
    var valorUm = document.getElementById('valorUm');
    var valorDois = document.getElementById('valorDois');

    var item = {
        valorUm: parseInt(valorUm.value),
        valorDois: parseInt(valorDois.value),
        resultado: parseInt(resultado.value)
    };

    fetch('/home/dividir', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(function (response) {
            return response.json();
        })
        .then(function (result) {
            resultado.value = result.resultado;
            valorUm.value = result.valorUm;
            valorDois.value = result.valorDois;
        })
        .catch(error => console.error('Unable to add item.', error));
}

//Função de limpar
function limpar() {
    var resultado = document.getElementById('resultado');
    var valorUm = document.getElementById('valorUm');
    var valorDois = document.getElementById('valorDois');

    fetch('/home/limpar', {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(function () {
            resultado.value = null;
            valorUm.value = null;
            valorDois.value = null;
        })
        .catch(error => console.error('Unable to add item.', error));
}