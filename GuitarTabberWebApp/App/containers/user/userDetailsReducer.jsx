import { GETUSER_ERROR, GETUSER_SUCCESS } from './userConstants.jsx'

const initialState = {
    user: {},
    error: ''
}

export default function userDetailsReducer(state = initialState, action) {    
    switch (action.type) {
        case GETUSER_SUCCESS:
         
            return { ...state, tab: action.tab, error: '' }

        case GETUSER_ERROR:
            return { ...state, error: action.error }

        default:
            return state;
    }
}