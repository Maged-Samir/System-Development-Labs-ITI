function parsingData(url) {
    return fetch(url)
      .then(response => {
        if (!response.ok) {
          throw new Error(response.statusText);
        }
        return response.json();
      })
      .catch(error => {
        console.error(error);
      });
  }
  
  parsingData("https://jsonplaceholder.typicode.com/users")
    .then(data => {
      let table = `<table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Username</th>
                        <th>Email</th>
                      </tr>
                    </thead>
                    <tbody>`;
  
      data.forEach(user => {
        table += `<tr>
                    <td>${user.id}</td>
                    <td>${user.name}</td>
                    <td>${user.username}</td>
                    <td>${user.email}</td>
                  </tr>`;
      });
  
      table += `</tbody></table>`;
  
      document.getElementById("table").innerHTML = table;
    })
    .catch(error => {
      console.error(error);
    });