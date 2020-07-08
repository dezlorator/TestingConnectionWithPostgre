import React from 'react';
import {withInvoiceService} from '../hoc'

const App = ({invoiceService}) =>{
    console.log(invoiceService.getInvoices())
    return <div>App</div>
}

export default withInvoiceService()(App);