function buscarFilmes() {
    const table = document.getElementById('Filmes');
    const url = 'http://localhost:5000/api/Filmes';

    if (table.style.visibility === 'visible') {
        table.style.visibility = 'hidden';
    } else {
        table.style.visibility = 'visible';
    }

    fetch(url)
        .then((resp) => resp.json())
        .then(function (data) {
            console.log(data)


            let tab =
                `<tr>
                    <th>Filme</th>
                    <th>Gênero</th>
                </tr>`;

            let table = data;
            for (let r of table) {
                tab +=
                    `<tr>
                    <td>${r.titulo}</td>
                    <td>${r.idGeneroNavigation.nome}
                </tr>`;
            }

            document.getElementById('Filmes').innerHTML = tab;

        })
        .catch((error) => {
            console.log('Algo deu errado!' + error)
        })
}