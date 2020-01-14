import React, { useCallback } from "react";
import { useDropzone } from "react-dropzone";

interface IProps {
    setFiles: (files: object[]) => void;
}

const PhotoWidgetDropzone: React.FC<IProps> = ({setFiles}) => {
  const onDrop = useCallback(acceptedFiles => {
    setFiles(acceptedFiles.map((file:object) => Object.assign(file, {
        preview: URL.createObjectURL(file)
    })))
  }, []);
  const { getRootProps, getInputProps, isDragActive } = useDropzone({ onDrop });

  return (
    <div {...getRootProps()}>
      <input {...getInputProps()} />
      {isDragActive ? (
        <p>Drop the files here ...</p>
      ) : (
        <p>Drag 'n' drop some files here, or click to select files</p>
      )}
    </div>
  );
};
export default PhotoWidgetDropzone;
