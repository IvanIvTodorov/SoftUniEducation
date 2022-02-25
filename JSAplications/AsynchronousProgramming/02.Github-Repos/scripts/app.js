async function loadRepos() {
	let input = document.getElementById('username');
	let output = document.getElementById('repos');

	let btn = document.getElementsByTagName('button')[0];
	output.innerHTML = '';

	try {
		const response = await fetch(`https://api.github.com/users/${input.value}/repos`, {
			method: 'GET', // *GET, POST, PUT, DELETE, etc.
			mode: 'cors', // no-cors, *cors, same-origin
			cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
			credentials: 'same-origin', // include, *same-origin, omit
			headers: {
				'Authorization': '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'
			},
			redirect: 'follow', // manual, *follow, error
			referrerPolicy: 'no-referrer'
		});

		if (response.ok == false) {
			throw new Error(response.status);
		};

		let data = await response.json();

		for (const item of data) {

			let li = document.createElement('li');
			let ancher = document.createElement('a');

			ancher.href = item.html_url;
			ancher.textContent = item.full_name;

			li.appendChild(ancher);

			output.appendChild(li);
		};

	} catch (error) {
		let li = document.createElement('li');
		li.textContent = `Error: ${error.message} (Not Found)`;
		output.appendChild(li);
	};
}