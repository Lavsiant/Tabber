import { GET_TAB_SUCCESS, GET_TAB_ERROR, CREATE_TAB_SUCCESS, CREATE_TAB_ERROR } from './tabConstants.jsx'
import "isomorphic-fetch";
import { config } from '../../helpers/config.jsx';

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

export function createTab(tab) {
    const url = 'api/Tab/tab-create'; 
    const request = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(tab)
    };
    return (dispatch) => {        
        return fetch(url,request)
            .then((response) => {
                return response.json()
            }).then((data) => {               
                dispatch( {type: CREATE_TAB_SUCCESS, tab: data} );
                window.location = config.apiUrl + "/tabs";
            }).catch((ex) => {
                dispatch( {type: CREATE_TAB_ERROR, err: ex})
            });
    }
}