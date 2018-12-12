import { GET_TABS_ERROR, GET_TABS_SUCCESS } from './tabsConstants.jsx'

const initialState = {
    tabs: [],
    error: ''
}

export default function tabsReducer(state = initialState, action) {    
    switch (action.type) {
        case GET_TABS_SUCCESS:
            
            return { ...state, tabs: action.tabs, error: '' }

        case GET_TABS_ERROR:
            return { ...state, error: action.error }

        default:
            return state;
    }
}