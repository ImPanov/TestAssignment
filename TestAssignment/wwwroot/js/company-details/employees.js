export default class Employees {
    url = "https://localhost:7182/api/employees/company";
    id = location.pathname.match(/(?<=\/companydetails\/)[0-9]+/i);
    tableRender = document.querySelector('#employees-tbody');

    btnRefreshNotes = document.querySelector('#refresh-employees');

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
        let fNameInp = document.querySelector("#InputEmployee_FirstName");
        let lNameInp = document.querySelector("#InputEmployee_LastName");
        let titleInp = document.querySelector("#InputEmployee_Title");
        let BDateInp = document.querySelector("#InputEmployee_BirthDate");
        let PostInp = document.querySelector("#InputEmployee_Position");
        let fragment = document.createDocumentFragment();
        res.forEach(({firstName, lastName }) => { fragment.appendChild(this.renderRow({ firstName, lastName })); });
        this.tableRender.appendChild(fragment);
        let date = new Date(res[0].birthDate);
        let dateOut = date.getMonth() + '/' + date.getDay() + '/' + date.getFullYear();
        fNameInp.value = res[0].firstName;
        lNameInp.value = res[0].lastName;
        titleInp.value = res[0].title;
        BDateInp.value = dateOut;
        PostInp.value = res[0].Position;
    }
    event() {
        this.btnRefreshNotes.addEventListener('click', () => this.getData(this.id));
    }
};