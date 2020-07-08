
export default class InvoiceService{

    constructor(){}
    
    _getInvoicesUri = process.env.REACT_APP_SERVER_URL + "xero/accounts"

     async getInvoices(){
        const res = await fetch(this._getInvoicesUri);

        if(!res.ok){
            throw new Error(`Could not fetch ${this._getInvoicesUri} receive ${res.status}`)
          }
          const body = await res.json();
          return body;
    }
}