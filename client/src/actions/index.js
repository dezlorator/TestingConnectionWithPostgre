
const invoicesLoaded = (newInvoices) => {
    return {
        type: 'INVOICES_LOADED',
        payload: newInvoices
    }
}

export {
    invoicesLoaded
};