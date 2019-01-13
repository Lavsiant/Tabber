import { GET_COURSES_ERROR, GET_COURSES_SUCCESS } from './coursesConstants.jsx'

const initialState = {
    courses: [],
    error: ''
}

export default function coursesReducer(state = initialState, action) {    
    switch (action.type) {
        case GET_COURSES_SUCCESS:
            
            return { ...state, courses: action.courses, error: '' }

        case GET_COURSES_ERROR:
            return { ...state, error: action.error }

        default:
            return state;
    }
}