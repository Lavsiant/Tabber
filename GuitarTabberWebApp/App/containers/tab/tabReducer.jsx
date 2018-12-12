import { GET_TAB_ERROR, GET_TAB_SUCCESS } from './tabConstants.jsx'

const initialState = {
    tab: {},
    error: ''
}

export default function tabReducer(state = initialState, action) {    
    switch (action.type) {
        case GET_TAB_SUCCESS:
         
            return { ...state, tab: action.tab, error: '' }

        case GET_TAB_ERROR:
            return { ...state, error: action.error }

        default:
            return state;
    }
}