let fluxoCaixa = {
    enviar: () => {
        let dados = {
            valor: document.getElementById("valor").value,
            tipo: document.getElementById("tipo").value.toLowerCase(),
            motivo: document.getElementById("motivo").value
        }

        if (dados.tipo == "")
            alert("Tipo é obrigatório.");
        else if (dados.tipo == 'r' && motivo == "")
            alert("Motivo é obrigatório para essa operação.");
        else if (dados.valor == "")
            alert("Valor é obrigatório.");
        else if (dados.valor <= 0)
            alert("Valor não pode ser igual ou menor que zero.");
        else {
                HTTPClient.post("FluxoCaixa/Gravar", dados)
                    .then(result => {
                        return result.json();
                    })
                    .then(dados => {
                        if (dados.sucesso) 
                            alert(dados.msg);
                    })
                    .catch(() => {
                        console.log("Erro ao gravar operação.");
                    });
             }
    }
}
