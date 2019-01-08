import { GET_COURSE_ERROR, GET_COURSE_SUCCESS, CREATE_COURSE_SUCCESS, CREATE_COURSE_ERROR } from './courseConstants.jsx'

const initialState = {
    course: {},
    error: ''
}

export default function courseReducer(state = initialState, action) {    
    switch (action.type) {
        case GET_COURSE_SUCCESS:
         
            return { ...state, course: action.course, error: '' }

        case GET_COURSE_ERROR:
            return { ...state, error: action.error }

        case CREATE_COURSE_SUCCESS:
             return { ...state}

        case CREATE_COURSE_SUCCESS:
             return { ...state, course: action.course}
        
        case CREATE_COURSE_ERROR:
            return {...state, error: action.err}

        default:
            return state;
    }
}