import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import Paper from '@material-ui/core/Paper';
import TextField from '@material-ui/core/TextField';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import InputLabel from '@material-ui/core/InputLabel';
import MenuItem from '@material-ui/core/MenuItem';
import Input from '@material-ui/core/Input';
import { createTab } from './tabActions.jsx';
import Button from '@material-ui/core/Button';
import { config } from '../../helpers/config.jsx';

class CreateTab extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
            tempo: 0,
            creator: '',
            type: 0,
            iteration: {
                tempScale: 1, strings: [
                    { string: 1, note: '' },
                    { string: 2, note: '' },
                    { string: 3, note: '' },
                    { string: 4, note: '' },
                    { string: 5, note: '' },
                    { string: 6, note: '' },
                ]
            },
            iterations: []
        };
        if (localStorage.getItem('user')) {
            this.state.creator = JSON.parse(localStorage.getItem('user')).username;
        }
        else {
            window.location = config.apiUrl + "/login";
        }
    }

    handleChange = (e) => {
        const { name, value } = e.target;
        this.setState({ [name]: value });
    }

    handleIterationChange = (e) => {
        const { name, value } = e.target;
        const { iteration } = this.state;
        if (name === "tempScale") {
            iteration.tempScale = value;
        }
        else {
            iteration.strings[+name - 1].note = value;
        }
        // iteration[name] = value;
        this.setState({ iteration: iteration })
    }

    handleSubmit = (e) => {
        e.preventDefault();
        this.setState({ submitted: true });
        const { name, tempo } = this.state;
        this.props.createTab({ name: this.state.name, tempo: this.state.tempo, type: this.state.type, creator: this.state.creator });
    }

    handleAddIterationClickButton = (e) => {
        const { iterations, iteration } = this.state;     
        let newIteration = {tempScale: iteration.tempScale, strings: []};
        for(let i = 0;i<iteration.strings.length;i++){
            if(iteration.strings[i].note !== ''){
                newIteration.strings.push(iteration.strings[i]);
            }         
        }
        if(newIteration.strings.length>0){
            iterations.push(newIteration);
        }
        this.setState({ iterations: iterations, iteration: {   tempScale: 1, strings: [
            { string: 1, note: '' },
            { string: 2, note: '' },
            { string: 3, note: '' },
            { string: 4, note: '' },
            { string: 5, note: '' },
            { string: 6, note: '' },
        ] } });
    }

    handleRemoveIterationClickButton = (e) => {
        const { iterations, iteration } = this.state;
        iterations.splice(e, 1);
        this.setState({ iterations: iterations });
    }

    render() {
        const { name, tempo } = this.state;
        const strings = [1, 2, 3, 4, 5, 6];
        let counter = -1;
        return (
            <Paper className='tab-create'>
                <div >
                    <h2>Create</h2>
                    <form name="form" className='tab-create-form' onSubmit={this.handleSubmit}>
                        <div className='field'>
                            <label>Name: </label>
                            <Input type="text" placeholder="Tab name" className="form-control" name="name" value={name} onChange={this.handleChange} />
                        </div>
                        <div className='field'>
                            <label>Tempo: </label>
                            <Input type="number" placeholder="Tempo" className="form-control" name="tempo" value={tempo} onChange={this.handleChange} />
                        </div>
                        <div className='field'>
                            <InputLabel htmlFor="age-simple">Type </InputLabel>
                            <Select
                                value={this.state.type}
                                onChange={this.handleChange}
                                inputProps={{
                                    name: 'type',
                                    id: 'age-simple',
                                }}
                            >
                                <MenuItem value={0}>
                                    <em>None</em>
                                </MenuItem>
                                <MenuItem value={1}>Guitar</MenuItem>
                                <MenuItem value={2}>Drums</MenuItem>
                                <MenuItem value={3}>Piano</MenuItem>
                            </Select>
                        </div>
                        {this.state.iterations.map(iteration => {
                            counter++;
                            return (
                                <Paper className='root'>
                                    <label>tempScale: {iteration.tempScale} </label>
                                    {iteration.strings.map(string => {
                                        return(
                                        <div>
                                            <label>String: {string.string} </label>
                                            <label>Note: {string.note} </label>
                                        </div>
                                        )
                                    })}
                                    <Button type='button' onClick={() => this.handleRemoveIterationClickButton(counter)} style={{ marginLeft: 5 }}>Remove</Button>
                                </Paper>
                            );
                        })}
                        <Paper className='root'>
                            <label> Temp scale: </label>
                            <Input type="number" inputProps={{ min: 0, max: 10 }} placeholder="Temp scale" className="form-control" name="tempScale" value={this.state.iteration.tempScale} onChange={this.handleIterationChange} />
                            {strings.map(string => {
                                return (
                                    <div>
                                        <label> String: {string} </label>

                                        <label> Note: </label>
                                        <Input type="number" inputProps={{ min: 0, max: 18 }} placeholder="None" className="form-control" name={string.toString()} value={this.state.iteration.strings[string-1].note} onChange={this.handleIterationChange} />
                                    </div>
                                );
                            })}
                            <Button type='button' onClick={this.handleAddIterationClickButton} style={{ marginLeft: 5 }}>Add</Button>

                        </Paper>


                        <div className="form-group">
                            <Button size='large' type='submit' className="form-group">Create</Button>
                        </div>
                    </form>
                </div>
            </Paper>
        );
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
        createTab: bindActionCreators(createTab, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(CreateTab) 