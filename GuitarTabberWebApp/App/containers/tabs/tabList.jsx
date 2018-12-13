import React from 'react';
import ReactDOM from 'react-dom';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import queryString from 'query-string';
import { Link } from 'react-router-dom';
import { getTabs } from './tabsActions.jsx'
import { withStyles } from '@material-ui/core/styles';
import "isomorphic-fetch";
import Paper from '@material-ui/core/Paper';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import TablePaginationActions from '../common/tablePaginationActions.jsx';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import TableHead from '@material-ui/core/TableHead';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableFooter from '@material-ui/core/TableFooter';
import TablePagination from '@material-ui/core/TablePagination';
import TableRow from '@material-ui/core/TableRow';
import FilterTabBar from './filterTabBar.jsx';

class TabList extends React.Component {
    constructor() {
        super();
        this.state = {
            filteredTabs: [],
            page: 0,
            rowsPerPage: 5
        };
    }

    componentDidMount() {
        this.props.getTabs().then(() =>
            this.setState({ filteredTabs: this.props.tabs })
        );

    }

    handleChangePage = (event, page) => {
        this.setState({ page });
    };

    handleChangeRowsPerPage = event => {
        this.setState({ rowsPerPage: +event.target.value });
    };

    filterTabs = (filterOptions) => {
        let tabs = this.props.tabs;
        if (filterOptions.name)
            tabs = tabs.filter(x => x.name.toLowerCase().includes(filterOptions.name.toLowerCase()));
        tabs = filterOptions.minTempo ? tabs.filter(x=>x.tempo > filterOptions.minTempo) : tabs;
        tabs = filterOptions.maxTempo ? tabs.filter(x=>x.tempo < filterOptions.maxTempo) : tabs;
        // tabs = !isNaN(filterOptions.minTempo) ? tabs.filter(x=>+x.tempo >= +filterOptions.minTempo) : tabs;
        this.setState({ filteredTabs: tabs });
    }

    render() {

        const { rowsPerPage, page } = this.state;
        const emptyRows = rowsPerPage - Math.min(rowsPerPage, this.state.filteredTabs.length - page * rowsPerPage);

        return (
            <Paper className='root'>
                <Link to='/tab-create'>Create tab</Link>
                <FilterTabBar filterTabs={this.filterTabs}></FilterTabBar>
                <div className='table-wrapper'>
                    <Table className={'table'}>
                        <TableHead>
                            <TableRow>
                                <TableCell>Name</TableCell>
                                <TableCell numeric>Tempo (bmp)</TableCell>
                                <TableCell numeric>Creator</TableCell>

                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {this.state.filteredTabs.slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage).map(tab => {
                                return (
                                    <TableRow key={tab.id} className="table-field"  component={Link} to={'/tab/' + tab.id}>
                                        <TableCell  component="th" scope="row" >
                                            {tab.name}
                                        </TableCell>
                                        <TableCell numeric>{tab.tempo}</TableCell>
                                        <TableCell numeric>{tab.creator}</TableCell>
                                    </TableRow>
                                );
                            })}
                            {emptyRows > 0 && (
                                <TableRow style={{ height: 48 * emptyRows }}>
                                    <TableCell colSpan={6} />
                                </TableRow>
                            )}
                        </TableBody>
                        <TableFooter>
                            <TableRow>
                                <TablePagination
                                    rowsPerPageOptions={[2, 5, 10, 25]}
                                    colSpan={3}
                                    count={this.props.tabs.length}
                                    rowsPerPage={rowsPerPage}
                                    page={page}
                                    SelectProps={{
                                        native: true,
                                    }}
                                    onChangePage={this.handleChangePage}
                                    onChangeRowsPerPage={this.handleChangeRowsPerPage}
                                    ActionsComponent={TablePaginationActions}
                                />
                            </TableRow>
                        </TableFooter>
                    </Table>
                </div>
            </Paper>
        );
    }
};

let mapProps = (state) => {
    return {
        tabs: state.tabsReducer.tabs,
        error: state.tabsReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getTabs: bindActionCreators(getTabs, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(TabList) 