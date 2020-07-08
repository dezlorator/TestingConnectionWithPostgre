import React from 'react'
import ReactDom from 'react-dom'
import {Provider} from 'react-redux';
import {BrowserRouter as Router} from 'react-router-dom'

import App from './components/app/app';
import InvoiceService from './services/invoiceService';
import {ServiceProvider} from './components/service-context';

import store from './store';

const invoiceService = new InvoiceService();

ReactDom.render(
    <Provider store={store}>
        <ServiceProvider value={invoiceService}>
            <Router>
                <App/>
            </Router>
        </ServiceProvider>
    </Provider>,
    document.getElementById('root')
);