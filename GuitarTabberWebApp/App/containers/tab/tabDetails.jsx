import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getTab } from './tabActions.jsx'
import Paper from '@material-ui/core/Paper';

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
            <Paper className='login'>
            <div className = 'root'>
                <div>Id = {this.props.tab.id}</div>
                <div>Name = {this.props.tab.name}</div>
                <div>Tempo = {this.props.tab.tempo}</div>
                <div>Creator = {this.props.tab.creator}</div>
            </div>
            </Paper>)
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
