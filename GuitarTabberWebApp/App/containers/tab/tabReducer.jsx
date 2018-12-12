import { GET_TAB_ERROR, GET_TAB_SUCCESS, CREATE_TAB_SUCCESS, CREATE_TAB_ERROR } from './tabConstants.jsx'

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

        case CREATE_TAB_SUCCESS:
             return { ...state}

        case CREATE_TAB_SUCCESS:
             return { ...state, tab: action.tab}
        
        case CREATE_TAB_ERROR:
            return {...state, error: action.err}

        default:
            return state;
    }
}