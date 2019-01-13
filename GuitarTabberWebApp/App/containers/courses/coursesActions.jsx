import { GET_COURSES_SUCCESS, GET_COURSES_ERROR } from './coursesConstants.jsx'
import "isomorphic-fetch"

export function receiveTabs(data) {
    return {
        type: GET_COURSES_SUCCESS,
        courses: data
    }
}

export function errorReceive(err) {
    return {
        type: GET_COURSES_ERROR,
        error: err
    }
}

export function getCourses() {
    return (dispatch) => {
        return fetch(constants.getCourses)
            .then((response) => {
                return response.json()
            }).then((data) => {
                dispatch(receiveTabs(data))
            }).catch((ex) => {
                dispatch(errorReceive(ex))
            });
    }
}