function solve(){
   let author = document.getElementById('creator');
   let title = document.getElementById('title');
   let category = document.getElementById('category');
   let content = document.getElementById('content');

   let btnCreate = document.getElementsByClassName('btn create')[0];
   btnCreate.type = 'button';

   let ol = document.getElementsByTagName('ol')[0];

   btnCreate.addEventListener('click', addArticle);

   let posts = document.getElementsByTagName('section')[1];

   function addArticle(){
      let article = document.createElement('article');
      let h1 = document.createElement('h1');
      h1.textContent = title.value;

      let pCat = document.createElement('p');
      pCat.textContent = `Category:`;

      let strongCat = document.createElement('strong');
      strongCat.textContent = category.value;

      let pCreator = document.createElement('p');
      pCreator.textContent = `Creator:`;

      let strongCreate = document.createElement('strong');
      strongCreate.textContent = author.value;

      let p  = document.createElement('p');
      p.textContent = content.value;

      let div = document.createElement('div');
      div.classList.add('buttons');

      let delBtn = document.createElement('button');
      delBtn.classList.add('btn');
      delBtn.classList.add('delete');
      delBtn.textContent = 'Delete';
      delBtn.addEventListener('click', del);

      let archBtn = document.createElement('button');
      archBtn.classList.add('btn');
      archBtn.classList.add('archive');
      archBtn.textContent = 'Archive';
      archBtn.addEventListener('click', archive);

      article.appendChild(h1);
      pCat.appendChild(strongCat);
      article.appendChild(pCat);
      pCreator.appendChild(strongCreate);
      article.appendChild(pCreator);
      article.appendChild(p);
      div.appendChild(delBtn);
      div.appendChild(archBtn);
      article.appendChild(div);

      posts.appendChild(article);
      author.value = '';
      category.value = '';
      title.value = '';
      content.value = '';

      function del(){

         article.remove();
      };

      function archive(){

         let li = document.createElement('li');
         li.textContent = h1.textContent;
         ol.appendChild(li);

         let arr = Array.from(ol.children);
         arr.sort((a,b) => a.innerHTML.localeCompare(b.innerHTML));

         for (const item of arr) {
            ol.appendChild(item);
         };
         
         del();
      };

   };
  };
