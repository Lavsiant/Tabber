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
import { FormLabel } from '@material-ui/core';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import Typography from '@material-ui/core/Typography';
import NoSsr from '@material-ui/core/NoSsr';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';

class CreateTab extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
            tempo: 0,
            creator: '',
            type: 0,
            iteration: {
                WaitTimeScalar: 1, activeNotes: [
                    { StringNumber: 1, Fret: '' },
                    { StringNumber: 2, Fret: '' },
                    { StringNumber: 3, Fret: '' },
                    { StringNumber: 4, Fret: '' },
                    { StringNumber: 5, Fret: '' },
                    { StringNumber: 6, Fret: '' },
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
            iteration.WaitTimeScalar = value;
        }
        else {
            iteration.activeNotes[+name - 1].Fret = value;
        }
        // iteration[name] = value;
        this.setState({ iteration: iteration })
    }

    handleSubmit = (e) => {
        e.preventDefault();
        this.setState({ submitted: true });
        const { name, tempo } = this.state;
        this.props.createTab({ name: this.state.name, tempo: this.state.tempo, type: this.state.type, creator: this.state.creator, iterations: this.state.iterations });
    }

    handleAddIterationClickButton = (e) => {
        const { iterations, iteration } = this.state;
        let newIteration = { WaitTimeScalar: iteration.WaitTimeScalar, activeNotes: [] };
        for (let i = 0; i < iteration.activeNotes.length; i++) {
            if (iteration.activeNotes[i].Fret !== '') {
                newIteration.activeNotes.push(iteration.activeNotes[i]);
            }
        }
        if (newIteration.activeNotes.length > 0) {
            iterations.push(newIteration);
        }
        this.setState({
            iterations: iterations, iteration: {
                WaitTimeScalar: 1, activeNotes: [
                    { StringNumber: 1, Fret: '' },
                    { StringNumber: 2, Fret: '' },
                    { StringNumber: 3, Fret: '' },
                    { StringNumber: 4, Fret: '' },
                    { StringNumber: 5, Fret: '' },
                    { StringNumber: 6, Fret: '' },
                ]
            }
        });
    }

    handleRemoveIterationClickButton = (e) => {
        const { iterations, iteration } = this.state;
        iterations.splice(e, 1);
        this.setState({ iterations: iterations });
    }

    getStringName = (x) => {
        switch (x) {
            case 1: return 'First string';
            case 2: return 'Second string';
            case 3: return 'Third string';
            case 4: return 'Fourth string';
            case 5: return 'Fifth string';
            case 6: return 'Sixth string';
        }
    }

    render() {
        const { name, tempo } = this.state;
        const strings = [1, 2, 3, 4, 5, 6];
        const styles = theme => ({
            container: {
                display: 'flex',
                flexWrap: 'wrap',
            },
            textField: {
                marginLeft: theme.spacing.unit,
                marginRight: theme.spacing.unit,
            },
            dense: {
                marginTop: 16,
            },
            menu: {
                width: 200,
            },
        });
        let counter = 1;
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <Paper className='tab-create' style={{ marginTop: 100, paddingBottom: 20 }} >
                <div style={{ textAlign: 'center' }}>
                    <h2>{language == 'en' ? 'Create' : 'Створення'}</h2>
                    <form name="form" className='tab-create-form' onSubmit={this.handleSubmit} style={{ textAlign: 'center' }}>
                        <div className='field'>
                            <TextField
                                style={{ width: '90%' }}
                                label={language == 'en' ? "Tab name" : 'Назва табулатури'}
                                className={styles.textField}
                                type="text"
                                name="name"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={name}
                                onChange={this.handleChange}
                                required
                            />

                        </div>
                        <div className='field'>
                            <TextField
                                style={{ width: '90%' }}
                                label={language == 'en' ? "Tempo" : 'Темп'}
                                className={styles.textField}
                                type="number"
                                name="tempo"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={tempo}
                                onChange={this.handleChange}
                                required
                            />
                        </div>
                        <div className='field'>
                            <TextField
                                select
                                label={language == 'en' ? "Select type" : 'Тип'}
                                className={styles.textField}
                                style={{ width: '90%' }}
                                value={this.state.type}
                                name='type'
                                SelectProps={{
                                    MenuProps: {
                                        className: styles.menu,
                                    },
                                }}
                                helperText={language == 'en' ? "Please select type" : 'Будь ласка оберіть тип'}
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChange}
                            >
                                <MenuItem value={1}>{language == 'en' ? 'Acoustic Guitar' : 'Акустична гітара'}</MenuItem>
                                <MenuItem value={2}>{language == 'en' ? 'Electric Guitar' : 'Електрогітара'}</MenuItem>
                                <MenuItem value={3}>{language == 'en' ? 'Classical Guitar' : 'Класична гітара'}</MenuItem>
                            </TextField>
                            {/* <InputLabel htmlFor="age-simple">Type </InputLabel>
                            <Select
                                style={{ width: '90%' }}
                                value={this.state.type}
                                onChange={this.handleChange}
                                inputProps={{
                                    name: 'type',
                                    id: 'age-simple',
                                }}
                            >
                                <MenuItem value={1}>Acoustic Guitar</MenuItem>
                                <MenuItem value={2}>Electric Guitar</MenuItem>
                                <MenuItem value={3}>Classical Guitar</MenuItem>
                            </Select> */}
                        </div>
                        {/* {this.state.iterations.map(iteration => {
                            counter++;
                            return (
                                <Paper className='root' style={{ textAlign: 'left', width: 'max-content', margin: 'auto', marginBottom: 100 }}>
                                    <label><b>Tempo Scale:</b> {iteration.WaitTimeScalar} bpm</label>
                                    {iteration.activeNotes.map(string => {
                                        return (
                                            <span>
                                                <label> <b>|</b> String: {string.StringNumber} </label>
                                                <label> Note: {string.Fret} </label>
                                            </span>
                                        )
                                    })}
                                    <Button type='button' onClick={() => this.handleRemoveIterationClickButton(counter)} style={{ marginLeft: 5 }}>Remove</Button>
                                </Paper>
                            );
                        })} */}
                        <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Вправи' : 'Ітерації'}</FormLabel>
                        {this.state.iterations.map(iteration => {
                            const co = counter;
                            return (
                                <ExpansionPanel style={{ width: '80%', margin: 'auto', marginBo: '15' }}>
                                    <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                        <Typography >{language == 'en' ? 'Iteration' : 'Ітерація'} {counter++}</Typography>
                                        
                                    </ExpansionPanelSummary>
                                    <ExpansionPanelDetails>
                                        <Typography style={{ fontSize: 18, width: '100%' }}>
                                        {language == 'en' ? 'Tempo scale' : 'Коефіцієнт очікування'}: {iteration.WaitTimeScalar} 
                                            <br />
                                            {iteration.activeNotes.map(x => {
                                                return (
                                                    <label>  &nbsp;&nbsp;&nbsp; {x.StreingNumber}S-{x.Fret}F  &nbsp;&nbsp;&nbsp; </label>
                                                )
                                            })}
                                           <Button size="small"  type='button' onClick={() => this.handleRemoveIterationClickButton(co-1)} style={{ marginLeft: '80%' }}>{language == 'en' ? 'Remove' : 'Видалити'}</Button>
                               
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
                        <div style={{marginTop: 30}}>

                        </div>
                        <Paper className='root' style={{ width: '60%', margin: 'auto', paddingBottom: 15 }}>
                            <TextField
                                style={{ width: '90%' }}
                                label={language == 'en' ? "Tempo scale" : 'Коефіцієнт очікування'}
                                className={styles.textField}
                                type="number"
                                name="WaitTimeScalar"
                                autoComplete="Username"
                                margin="normal"
                                variant="outlined"
                                value={this.state.iteration.WaitTimeScalar}
                                onChange={this.handleIterationChange}
                                required
                            />

                            {strings.map(string => {
                                return (
                                    <TextField
                                        style={{ width: '40%', padding: 10 }}
                                        label={this.getStringName(string)}
                                        className={styles.textField}
                                        type="number"
                                        name={string.toString()}
                                        autoComplete="Username"
                                        margin="normal"
                                        variant="outlined"
                                        value={this.state.iteration.activeNotes[string - 1].Fret}
                                        onChange={this.handleIterationChange}
                                    />
                                );
                            })}

                            <Button variant="contained" type='button' style={{ marginBot: 20, width: 150 }} color="primary" onClick={this.handleAddIterationClickButton} >{language == 'en' ? 'Add' : 'Добавити'}</Button>
                        </Paper>

                        <div className="form-group">
                            <Button size='large' variant="contained" type='submit' style={{ marginBot: 20 }} color="primary">{language == 'en' ? 'Create' : 'Створити'}</Button>
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