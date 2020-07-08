
const initialState = {
    invoices: []
};

const reducer = (state = initialState, action) =>{

    switch(action.type){
        case 'INVOICES_LOADED':
            return{
                invoices: action.payload
            };
            
        default:
            return state;
    }
    return state;
};

export default reducer;