import { GET_TABS_SUCCESS, GET_TABS_ERROR } from './tabsConstants.jsx'
import "isomorphic-fetch"

export function receiveTabs(data) {
    return {
        type: GET_TABS_SUCCESS,
        tabs: data
    }
}

export function errorReceive(err) {
    return {
        type: GET_TABS_ERROR,
        error: err
    }
}

export function getTabs() {
    return (dispatch) => {        
        return fetch(constants.getTabs)
            .then((response) => {
                return response.json()
            }).then((data) => {
                dispatch(receiveTabs(data))
            }).catch((ex) => {
                dispatch(errorReceive(ex))
            });
    }
}