function create(words) {

   let content = document.getElementById('content');

   for (const word of words) {
      let createDiv = document.createElement('div');

      let createParagraph = document.createElement('p');
      createParagraph.textContent = word;
      createParagraph.style.display = 'none';

      createDiv.appendChild(createParagraph);
      content.appendChild(createDiv);

      createDiv.addEventListener('click', onClick);
   }

   function onClick(ev){
      ev.target.children[0].style.display = '';
   }
}