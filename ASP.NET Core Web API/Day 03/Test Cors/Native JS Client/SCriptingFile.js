function displayData(data) {
    const ul = document.createElement('ul'); // create a new unordered list element
    data.forEach(item => {
      const li = document.createElement('li'); // create a new list item element
      li.textContent = item.name; // set the text content of the list item to the name property of the item
      ul.appendChild(li); // add the list item to the unordered list
    });
    document.body.appendChild(ul); // add the unordered list to the page
  }

  fetch('https://localhost:7018/WeatherForecast')
  .then(response => response.json())
  .then(data => {
    displayData(data);
  });