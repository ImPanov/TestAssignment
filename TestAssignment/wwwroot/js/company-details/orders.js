export default class Orders {
    url = "https://localhost:7182/api/Orders/company";
    id = location.pathname.match(/(?<=\/companydetails\/)[0-9]+/i)[0];
    tableRender = document.querySelector('#orders-tbody');

    btnRefreshNotes = document.querySelector('#refresh-orders');

    constructor() {
        this.event();
        /*this.getData(this.id);*/
    };
    renderRow(row) {
        let tr = document.createElement('tr');
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
        res.forEach(({ dateOrder, storeCity }) => { fragment.appendChild(this.renderRow({ dateOrder, storeCity })); });
        this.tableRender.appendChild(fragment);
    }
    event() {
        this.btnRefreshNotes.addEventListener('click', () => this.getData(this.id));
    }
};