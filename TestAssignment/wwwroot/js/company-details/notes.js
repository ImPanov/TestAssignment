export default class Notes  {
    url = "https://localhost:7182/api/Notes/company";
    id = location.pathname.match(/(?<=\/companydetails\/)[0-9]+/i);
    tableRender = document.querySelector('#notes-tbody');

    btnRefreshNotes = document.querySelector('#refresh-notes');

    constructor() {
        this.event();
        /*this.getData(this.id);*/
    };
    renderRow(row) {
        let tr = document.createElement('tr');
        row.firstName = row.firstName + ' ' + row.lastName;
        delete row.lastName;
        for (var i in row) {
            let td = document.createElement('td');
            td.appendChild(document.createTextNode(row[i]));
            tr.appendChild(td);
        }
        return tr;
    }
    
    async getData(id) {
        let response = await fetch(this.url + '/' + id);
        let result = await response.json();
        this.render(result);
    }
    
    render(res) {
        this.tableRender.textContent = '';
        let fragment = document.createDocumentFragment();
        res.forEach(({ invoiceNumber, firstName, lastName }) => { fragment.appendChild(this.renderRow({ invoiceNumber, firstName, lastName })); });
        this.tableRender.appendChild(fragment);
    }
    event() {
        this.btnRefreshNotes.addEventListener('click', () => this.getData(this.id) );
    }
};