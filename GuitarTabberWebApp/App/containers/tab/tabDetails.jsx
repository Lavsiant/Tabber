import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getTab } from './tabActions.jsx'

import "isomorphic-fetch";


class TabDetails extends React.Component {
    constructor() {
        super();
        this.state = {
            
        };
    }

    componentDidMount() {
        this.props.getTab(this.props.id);
        //  this.state.selectedTab =  this.props.tabs ? this.props.tabs[0] : null
    }

    render() {
     
        return (
            <div>as{this.props.tab.id}</div>)
        }
}

let mapProps = (state) => {
    return {
        tab: state.tabReducer.tab,
        error: state.tabReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getTab: bindActionCreators(getTab, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(TabDetails) 
