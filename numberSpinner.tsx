import React from 'react';
import { makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import clsx from 'clsx';
import Paper from '@material-ui/core/Paper';
import InputBase from '@material-ui/core/InputBase';
import IconButton from '@material-ui/core/IconButton';
import Fab from '@material-ui/core/IconButton';
import SearchIcon from '@material-ui/icons/Search';
import CustomInput from './customInput';
import RemoveIcon from '@material-ui/icons/Remove';
import AddIcon from '@material-ui/icons/Add';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      padding: '2px 4px',
      display: 'flex',
      alignItems: 'center',
      width: 'auto',
      height: 55,
    },
    input: {
      textAlign: 'center',
      marginLeft: theme.spacing(1),
      marginRight: theme.spacing(1),
    },
    iconButton: {
      padding: 3,
      color: 'white',
    },
    minusButton: {
      backgroundColor: '#dc3545',
    },
    plusButton: {
      backgroundColor: '#28a745',
    },
    divider: {
      height: 28,
      margin: 4,
    },
  }),
);

type Props = {
  
}

const NumberSpinner: React.FC<Props> = props => {
  const classes = useStyles();

  return (
    <>
      <Fab className={clsx(classes.iconButton, classes.minusButton)} aria-label="minus">
        <RemoveIcon />
      </Fab>

      <CustomInput className={classes.input}  />

      <Fab className={clsx(classes.iconButton, classes.plusButton)} aria-label="plus">
        <AddIcon />
      </Fab>
    </>
  );
}

export default NumberSpinner;
