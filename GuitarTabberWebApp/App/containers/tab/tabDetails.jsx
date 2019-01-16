import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getTab } from './tabActions.jsx'
import Paper from '@material-ui/core/Paper';

import "isomorphic-fetch";
import { FormLabel } from '@material-ui/core';
import TextField from '@material-ui/core/TextField';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import Typography from '@material-ui/core/Typography';
import NoSsr from '@material-ui/core/NoSsr';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import Button from '@material-ui/core/Button';

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

    getTypeString = (x) => {
        switch (x) {
            case 1: return 'Acoustic Guitar';
            case 2: return 'Electric Guitar';
            case 3: return 'Classical Guitar';
        }
    }

    render() {
        let count = 1;
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <Paper className='tab-create' style={{ fontSize: 20, marginTop: 100, paddingBottom: 50 }} >
            <div style={{ textAlign: 'center', display: 'block' }}>
                <div>
                <FormLabel style={{ fontSize: 22 }}>{language == 'en' ? 'Tab name' : 'Назва табулатури'} </FormLabel>
                <br/>
                <TextField
                    style={{ width: '85%' }}
                    id="outlined-read-only-input"
                    value={this.props.tab.name}
                    defaultValue="Hello World"
                    margin="normal"
                    InputProps={{
                        readOnly: true,
                    }}
                    variant="outlined"
                />
                </div>
                <br />
                <div style={{ marginTop: 20 }}>
                    <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Tempo' : 'Темп'} </FormLabel>
                    <br/>
                    <TextField
                        style={{  width: '85%' }}
                        id="outlined-read-only-input"
                        value={this.props.tab.tempo}
                        defaultValue="Default decription"
                        margin="normal"
                        InputProps={{
                            readOnly: true,
                        }}
                        variant="outlined"
                    />
                </div>
                <br/>
                <div style={{ marginTop: 20}}>
                    <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Type': 'Тип'}</FormLabel>
                    <br/>
                    <TextField
                        style={{ width: '85%' }}
                        id="outlined-read-only-input"
                        value={this.getTypeString(this.props.tab.type)}
                        defaultValue="Hello World"
                        margin="normal"
                        InputProps={{
                            readOnly: true,
                        }}
                        variant="outlined"
                    />
                </div>
                <br/>
                <div style={{ marginTop: 20, marginBottom: 30 }}>
                    <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Creator' : 'Автор'}</FormLabel>
                    <br/>
                    <TextField
                        style={{ width: '85%' }}
                        id="outlined-read-only-input"
                        value={this.props.tab.creator}
                        defaultValue="Hello World"
                        margin="normal"
                        InputProps={{
                            readOnly: true,
                        }}
                        variant="outlined"
                    />
                </div>
                <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Iteration' : 'Ітерації'}</FormLabel>
                {this.props.tab.iterations.map(iteration => {
                        return (
                            <ExpansionPanel style={{ width: '85%', margin: 'auto', marginBop: '15' }}>
                                <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                    <Typography >{language == 'en' ? 'Iteration' : 'Ітерації'} {count++}</Typography>
                                </ExpansionPanelSummary>
                                <ExpansionPanelDetails>
                                    <Typography style={{ fontSize: 18 }}>
                                    {language == 'en' ? 'Tempo scale' : 'Коефіцієнт очікування'}: {iteration.waitTimeScalar} bpm
                                        <br/>
                                        {iteration.activeNotes.map(x=>{
                                            return(
                                                <label>  &nbsp;&nbsp;&nbsp; {x.stringNumber}S-{x.fret}F  &nbsp;&nbsp;&nbsp; </label>
                                            )
                                        })}
                                    </Typography>
                                </ExpansionPanelDetails>
                            </ExpansionPanel>
                            // <Paper className='root' style={{textAlign:'left', width:'max-content', margin:'auto' ,marginBottom:20}}>
                            //     <label>Lesson name: {lesson.name} </label>
                            //     <label>Repeat: {lesson.name} </label>
                            //     <label>Start Bpm: {lesson.startBpm} </label>
                            //     <label>Step Bpm: {lesson.stepBpm} </label>

                            //     <Button type='button' onClick={() => this.handleRemoveIterationClickButton(counter)} style={{ marginLeft: 5 }}>Remove</Button>
                            // </Paper>
                        );
                    })}

               



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
