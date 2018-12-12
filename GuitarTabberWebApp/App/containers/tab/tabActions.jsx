import { GET_TAB_SUCCESS, GET_TAB_ERROR } from './tabConstants.jsx'
import "isomorphic-fetch"

export function receiveTab(data) {
    return {
        type: GET_TAB_SUCCESS,
        tab: data
    }
}

export function errorReceive(err) {
    return {
        type: GET_TAB_ERROR,
        error: err
    }
}

export function getTab(id) {
    const url = 'api/Tab/tab?id=' + id; 
    return (dispatch) => {        
        fetch(url)
            .then((response) => {
                return response.json()
            }).then((data) => {
                dispatch(receiveTab(data))
            }).catch((ex) => {
                dispatch(errorReceive(ex))
            });
    }
}